using System;

namespace Task3_4;

public interface IBaseArray : IPrinter
{
    public void RndFill();
    public void FillByUser();
}