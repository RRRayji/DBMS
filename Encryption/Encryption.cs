namespace PC_SHOP
{
	public abstract class Encryption
    {
        private static byte _Length = 32;
        private static string _password = "";
        private static string _hash = "";
        private static byte[] _passwordBytes = new byte[_Length];

        private static string _abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string _symbols = "5{1!@$%:;0^3&8*(4)_7[6]#2?/<>-9+}=";
        private static string _chars = _abc + _symbols;
        private static byte _firstHashcode;


        public static string GetHash()
		{
			return (_hash != "") ? _hash : null;
		}

		public static void ChangePassword(string _password)
		{
			_hash = "";
            Encryption._password = FillTo32byte(_password);
            ToBytes();
            ToHash();
		}

		public static string ChangeAndGetHash(string _password)
		{
			_hash = "";
            Encryption._password = FillTo32byte(_password);
			ToBytes();
			ToHash();
			return _hash;
		}

		private static string FillTo32byte(string _password)
		{
			switch (_password.Length)
			{
				case 32:
					return _password;
			}
			for (byte i = (byte)_password.Length, j = 0; i < _Length; ++i, ++j)
			{
				_password += _symbols[(byte)(_password[(i + j) % _password.Length] + (byte)_abc[(byte)_password[i - 1] % _abc.Length]) % _symbols.Length];
			}
			_firstHashcode = (byte)_symbols[(byte)_password[8] % _symbols.Length];
			return _password;
		}

		private static void ToBytes()
		{
			_passwordBytes[0] = (byte)(_firstHashcode * (byte)_password[0] % 61);
			for (byte i = 1; i < _Length; ++i)
			{
				_passwordBytes[i] = (byte)((_passwordBytes[i - 1] * (byte)_password[i] + i) % 61);
			}
		}

		private static void ToHash()
        {
            byte[] reversed = Reverse(_passwordBytes);
            for (byte i = 0; i < _Length; ++i)
			{
				_hash += _chars[reversed[i] % _chars.Length];
			}
		}

		private static byte[] Reverse(byte[] toReverse)
		{
			byte[] reversed = new byte[_Length];
			for (byte i = 0, j = (byte)(_Length - 1); i < _Length; ++i, --j)
			{
				reversed[i] = toReverse[j];
			}
			return reversed;
		}
	}
}
