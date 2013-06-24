﻿using System;

abstract class EncryptableBinaryDocument : BinaryDocument, IEncryptable
{
    public bool IsEncrypted { get; set; }

    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }

    public override string ToString()
    {
        return this.IsEncrypted ? base.ToStringHelper("encrypted") : base.ToString();
    }
}
