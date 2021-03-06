﻿using System;

namespace Redola.ActorModel.Framing
{
    public sealed class HereFrame : ControlFrame
    {
        public HereFrame(bool isMasked = false)
        {
            this.IsMasked = isMasked;
        }

        public HereFrame(byte[] data, bool isMasked = false)
            : this(isMasked)
        {
            this.Data = data;
        }

        public byte[] Data { get; private set; }
        public bool IsMasked { get; private set; }

        public override OpCode OpCode
        {
            get { return OpCode.Here; }
        }

        public byte[] ToArray(IActorFrameBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException("builder");
            return builder.EncodeFrame(this);
        }
    }
}
