using System.IO;

namespace milk_sales_manager.modules
{
    internal class GenerateString
    {
        public string StringID(string key, string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                string[] names = name.Split(' ');

                string fullID = "";

                for (int i = names.Length - 1; i >= 0; i--)
                {
                    fullID += names[i];
                }

                string preID = key + (fullID.Length >= 5 ? fullID.Trim().Substring(0, 5) : fullID);

                int remainingLength = 10 - preID.Length;
                if (remainingLength > 0)
                    preID += Path.GetRandomFileName().Replace(".", "").Substring(0, remainingLength);

                RegexInput reg = new RegexInput();
                string result = reg.RemoveVietnameseMarks(preID.ToLower());

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
