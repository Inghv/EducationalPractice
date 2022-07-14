namespace MorseCodeAlphabet
{
    public static class UsingIf
    {
        public static string GetMorseCode(char c)
        {
            if (c == 'A' || c == 'a')
            {
                return ".-";
            }

            if (c == 'B' || c == 'b')
            {
                return "-...";
            }

            if (c == 'C' || c == 'c')
            {
                return "-.-.";
            }

            if (c == 'D' || c == 'd')
            {
                return "-..";
            }

            if (c == 'e' || c == 'E')
            {
                return ".";
            }

            if (c == 'f' || c == 'F')
            {
                return "..-.";
            }

            if (c == 'g' || c == 'G')
            {
                return "--.";
            }

            if (c == 'h' || c == 'H')
            {
                return "....";
            }

            if (c == 'i' || c == 'I')
            {
                return "..";
            }

            if (c == 'j' || c == 'J')
            {
                return ".---";
            }

            if (c == 'k' || c == 'K')
            {
                return "-.-";
            }

            if (c == 'l' || c == 'L')
            {
                return ".-..";
            }

            if (c == 'm' || c == 'M')
            {
                return "--";
            }

            if (c == 'n' || c == 'N')
            {
                return "-.";
            }

            if (c == 'o' || c == 'O')
            {
                return "---";
            }

            if (c == 'p' || c == 'P')
            {
                return ".--.";
            }

            if (c == 'q' || c == 'Q')
            {
                return "--.-";
            }

            if (c == 'r' || c == 'R')
            {
                return ".-.";
            }

            if (c == 's' || c == 'S')
            {
                return "...";
            }

            if (c == 't' || c == 'T')
            {
                return "-";
            }

            if (c == 'u' || c == 'U')
            {
                return "..-";
            }

            if (c == 'v' || c == 'V')
            {
                return "...-";
            }

            if (c == 'w' || c == 'W')
            {
                return ".--";
            }

            if (c == 'x' || c == 'X')
            {
                return "-..-";
            }

            if (c == 'y' || c == 'Y')
            {
                return "-.--";
            }

            if (c == 'z' || c == 'Z')
            {
                return "--..";
            }

            return string.Empty;
        }
    }
}
