﻿using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Services.Streams
{
    public class StreamFileTypeProvider : IStreamFileTypeProvider
    {
        private readonly IMapping _mapping;

        public StreamFileTypeProvider(IMapping mapping)
        {
            _mapping = mapping;
        }

        public async Task<FileType> FindByMagicByteSequenceAsync(
            Stream stream,
            CancellationToken cancellationToken
        )
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            var sequencesToFileTypes = _mapping.FileTypes
                .Select(fileType =>
                    fileType.MagicByteSequences
                        .Select(sequence => (sequence, fileType))
                )
                .SelectMany(group => group)
                .OrderBy(group => group.sequence.Length)
                .ToDictionary(
                    group => group.sequence,
                    group => group.fileType
                );

            if (!sequencesToFileTypes.Any())
            {
                return null;
            }

            var maxMagicBytesSequenceLength = sequencesToFileTypes.Keys
                .Last()
                .Length;
            var streamBuffer = new byte[maxMagicBytesSequenceLength];

            var previousStreamPosition = stream.Position;
            stream.Position = 0;

            await stream.ReadAsync(streamBuffer, 0, maxMagicBytesSequenceLength, cancellationToken);

            stream.Position = previousStreamPosition;

            foreach (var sft  in sequencesToFileTypes)
            {
                var sequence = sft.Key;
                var fileType = sft.Value;
                if (streamBuffer.Take(sequence.Length).SequenceEqual(sequence))
                {
                    return fileType;
                }
            }

            return null;
        }
    }
}
