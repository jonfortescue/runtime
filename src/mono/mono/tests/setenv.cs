using System;
using System.Runtime.InteropServices;

namespace Test {

	public class Test {
		[DllImport("libc")]
		static extern int setenv(string name, string value, int overwrite);
		[DllImport("libc")]
		static extern string getenv(string name);

		static int Main() {
			string name = "mono_test";
			string value = "val";

			setenv (name, value, 1);
			string ret = getenv (name);

			if (ret != value)
				return 1;
			return 0;
		}
	}
}
