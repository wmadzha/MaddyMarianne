using System.Collections.Generic;
namespace MaddyMarianne.Commander.Builder
{
    public static class InputBuilder
    {
        public static Dictionary<string,string> ToInputs(string message)
        {
            string[] inputs = message.Split(' ');
            var dictionary = new Dictionary<string, string>();
            int index = 1;
            for(int i = 2; i < inputs.Length; i++, index++)
            {
                dictionary.Add("message_"+ index.ToString(), inputs[i]);
               
            }
            return dictionary;
        }
    }
}
