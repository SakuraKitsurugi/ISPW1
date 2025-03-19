using System;
					
public class ISPW1
{
	public static void Main()
	{
		Console.WriteLine("Input text:\n");
		string inputText = Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Input key:\n");
		string inputKey = Console.ReadLine();
		Console.Clear();
		
		Console.WriteLine("Text: " + inputText + "\n");
		Console.WriteLine("Key " + inputKey + "\n");
		Console.WriteLine("Encrypted with ASCII: " + EncryptASCII(inputText, inputKey));
		Console.WriteLine("Decrypted with ASCII: " + DecryptASCII(inputText, inputKey));
	}
	
	public static string EncryptASCII(string text, string key){
		string encryptedText = "";
		
		for(int i = 0; i < text.Length; i++){
			int textLetter = (int)text[i];
			int keyLetter = (int)key[i % key.Length];
			int encryptedLetter = (textLetter + keyLetter) % 127;
			if(encryptedLetter < 32) { encryptedLetter += 32; }
			encryptedText += (char)encryptedLetter;
		}
		
		return encryptedText;
	}
	
	public static string DecryptASCII(string text, string key){
		string decryptedText = "";
		
		for(int i = 0; i < text.Length; i++){
			int textLetter = (int)text[i];
			int keyLetter = (int)key[i % key.Length];
			int decryptedLetter = (textLetter - keyLetter);
			//komentaras
			if(decryptedLetter < 0) { decryptedLetter += 127; }
			decryptedText += (char)decryptedLetter;
		}
		
		return decryptedText;
	}
}