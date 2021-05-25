
namespace Arrays {
    class ReverseString {
        public void Reverse(char [] str){
            for(int i = 0; i < str.Length/2; i++){
                char temp = str[i];
                str[i] = str[(str.Length-1)-i];
                str[str.Length-1] = temp;
                // System.Console.WriteLine("Temp: " + temp);
                // System.Console.WriteLine(str[i]);
            }

            foreach(char c in str){
                System.Console.WriteLine(c);
            }
        }
    }
}