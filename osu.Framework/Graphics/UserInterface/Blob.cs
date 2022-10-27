﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System;
using osu.Framework.Allocation;
using osu.Framework.Graphics.Rendering;
using osu.Framework.Graphics.Shaders;
using osu.Framework.Graphics.Sprites;

namespace osu.Framework.Graphics.UserInterface
{
    public class Blob : Sprite
    {
        [BackgroundDependencyLoader]
        private void load(ShaderManager shaders, IRenderer renderer)
        {
            Texture ??= renderer.WhitePixel;
            TextureShader = shaders.Load(VertexShaderDescriptor.TEXTURE_2, "Blob");
            RoundedTextureShader = shaders.Load(VertexShaderDescriptor.TEXTURE_2, "BlobRounded");
        }

        protected override DrawNode CreateDrawNode() => new BlobDrawNode(this);

        private float innerRadius = 0.2f;

        /// <summary>
        /// The inner fill radius, relative to the <see cref="Drawable.DrawSize"/> of the <see cref="Blob"/>.
        /// The value range is 0 to 1 where 0 is invisible and 1 is completely filled.
        /// The entire texture still fills the disk without cropping it.
        /// </summary>
        public float InnerRadius
        {
            get => innerRadius;
            set
            {
                if (!float.IsFinite(value))
                    throw new ArgumentException($"{nameof(InnerRadius)} must be finite, but is {value}.");

                innerRadius = Math.Clamp(value, 0, 1);
                Invalidate(Invalidation.DrawNode);
            }
        }

        private float amplitude = 0.3f;

        public float Amplitude
        {
            get => amplitude;
            set
            {
                if (!float.IsFinite(value))
                    throw new ArgumentException($"{nameof(Amplitude)} must be finite, but is {value}.");

                amplitude = Math.Clamp(value, 0, 1);
                Invalidate(Invalidation.DrawNode);
            }
        }

        private float frequency = 1.5f;

        public float Frequency
        {
            get => frequency;
            set
            {
                if (!float.IsFinite(value))
                    throw new ArgumentException($"{nameof(Frequency)} must be finite, but is {value}.");

                frequency = value;
                Invalidate(Invalidation.DrawNode);
            }
        }

        private int seed = 1;

        public int Seed
        {
            get => seed;
            set
            {
                seed = value;
                Invalidate(Invalidation.DrawNode);
            }
        }

        private class BlobDrawNode : SpriteDrawNode
        {
            public new Blob Source => (Blob)base.Source;

            public BlobDrawNode(Blob source)
                : base(source)
            {
            }

            private float innerRadius;
            private float texelSize;
            private float frequency;
            private float amplitude;
            private int seed;

            public override void ApplyState()
            {
                base.ApplyState();

                innerRadius = Source.innerRadius;
                frequency = Source.frequency;
                amplitude = Source.amplitude;
                seed = Source.seed;

                // smoothstep looks too sharp with 1px, let's give it a bit more
                texelSize = 1.5f / ScreenSpaceDrawQuad.Size.X;
            }

            protected override void Blit(IRenderer renderer)
            {
                var shader = GetAppropriateShader(renderer);

                shader.GetUniform<float>("innerRadius").UpdateValue(ref innerRadius);
                shader.GetUniform<float>("texelSize").UpdateValue(ref texelSize);
                shader.GetUniform<float>("frequency").UpdateValue(ref frequency);
                shader.GetUniform<float>("amplitude").UpdateValue(ref amplitude);
                shader.GetUniform<int>("seed").UpdateValue(ref seed);

                base.Blit(renderer);
            }

            protected internal override bool CanDrawOpaqueInterior => false;
        }
    }
}
