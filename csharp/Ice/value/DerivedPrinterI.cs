// **********************************************************************
//
// Copyright (c) 2003-2016 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

using Demo;

class DerivedPrinterI : DerivedPrinter
{
    public override void printBackwards(Ice.Current current)
    {
        char[] arr = message.ToCharArray();
        for(int i = 0; i < arr.Length / 2; i++)
        {
            char tmp = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = arr[i];
            arr[i] = tmp;
        }
        System.Console.Out.WriteLine(new string(arr));
    }
    
    public override void printUppercase(Ice.Current current)
    {
        System.Console.Out.WriteLine(derivedMessage.ToUpper());
    }
}
