namespace Extensions
{
	using System;
	using System.Text;

	public static class StringBuilderExtensions
	{
		public static StringBuilder Substring(this StringBuilder builder, int index, int length)
		{
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < length; i++)
			{
				result.Append(builder[index + i]);
			}

			return result;
		}
	}
}
