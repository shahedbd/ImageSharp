﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

// <auto-generated />
namespace SixLabors.ImageSharp.PixelFormats
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <content>
    /// Provides optimized overrides for bulk operations.
    /// </content>
    public partial struct Rgba32
    {
        internal partial class PixelOperations
        {
			
			/// <inheritdoc />
            internal override void PackFromRgb24(ReadOnlySpan<Rgb24> source, Span<Rgba32> destPixels, int count)
            {
                GuardSpans(source, nameof(source), destPixels, nameof(destPixels), count);

                ref Rgb24 sourceRef = ref MemoryMarshal.GetReference(source);
                ref Rgba32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Rgb24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba32 dp = ref Unsafe.Add(ref destRef, i);
                    Unsafe.As<Rgba32, Rgb24>(ref dp) = sp; dp.A = 255;
                }
            }
		
			/// <inheritdoc />
            internal override void ToRgb24(ReadOnlySpan<Rgba32> sourcePixels, Span<Rgb24> dest, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), dest, nameof(dest), count);

                ref Rgba32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Rgb24 destRef = ref MemoryMarshal.GetReference(dest);

                for (int i = 0; i < count; i++)
                {
                    ref Rgba32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgb24 dp = ref Unsafe.Add(ref destRef, i);
                    dp = Unsafe.As<Rgba32, Rgb24>(ref sp);
                }
            }
		
			/// <inheritdoc />
            internal override void PackFromBgr24(ReadOnlySpan<Bgr24> source, Span<Rgba32> destPixels, int count)
            {
                GuardSpans(source, nameof(source), destPixels, nameof(destPixels), count);

                ref Bgr24 sourceRef = ref MemoryMarshal.GetReference(source);
                ref Rgba32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgr24 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba32 dp = ref Unsafe.Add(ref destRef, i);
                    dp.Bgr = sp; dp.A = 255;
                }
            }
		
			/// <inheritdoc />
            internal override void ToBgr24(ReadOnlySpan<Rgba32> sourcePixels, Span<Bgr24> dest, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), dest, nameof(dest), count);

                ref Rgba32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgr24 destRef = ref MemoryMarshal.GetReference(dest);

                for (int i = 0; i < count; i++)
                {
                    ref Rgba32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgr24 dp = ref Unsafe.Add(ref destRef, i);
                    dp = sp.Bgr;
                }
            }
		
			/// <inheritdoc />
            internal override void PackFromBgra32(ReadOnlySpan<Bgra32> source, Span<Rgba32> destPixels, int count)
            {
                GuardSpans(source, nameof(source), destPixels, nameof(destPixels), count);

                ref Bgra32 sourceRef = ref MemoryMarshal.GetReference(source);
                ref Rgba32 destRef = ref MemoryMarshal.GetReference(destPixels);

                for (int i = 0; i < count; i++)
                {
                    ref Bgra32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Rgba32 dp = ref Unsafe.Add(ref destRef, i);
                    dp = sp.ToRgba32();
                }
            }
		
			/// <inheritdoc />
            internal override void ToBgra32(ReadOnlySpan<Rgba32> sourcePixels, Span<Bgra32> dest, int count)
            {
                GuardSpans(sourcePixels, nameof(sourcePixels), dest, nameof(dest), count);

                ref Rgba32 sourceRef = ref MemoryMarshal.GetReference(sourcePixels);
                ref Bgra32 destRef = ref MemoryMarshal.GetReference(dest);

                for (int i = 0; i < count; i++)
                {
                    ref Rgba32 sp = ref Unsafe.Add(ref sourceRef, i);
                    ref Bgra32 dp = ref Unsafe.Add(ref destRef, i);
                    dp = sp.ToBgra32();
                }
            }
		
		}
	}
}