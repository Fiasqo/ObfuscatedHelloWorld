using System;

namespace ObfuscatedHelloWorld {
internal static class Program {
    private static void Main() {
        const long letters = 0x726F6C6564574820;
        var indices = 0x357620655410;
        var helloWorld = string.Empty;

        while (indices != 0x0) helloWorld += (char) ((letters >> (((int) (indices >>= 4) & 7) << 3)) & 0xFF);
        Console.WriteLine(helloWorld);
    }
}
}