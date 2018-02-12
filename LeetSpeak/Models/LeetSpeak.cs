using System;
using System.Text;

namespace LeetSpeak
{
  public class LeetSpeak
  {
    public string Translate(string text)
    {
      for (int i = 0; i < text.Length; i++)
      {
        if(text[i] == 'e'){
          StringBuilder sb = new StringBuilder(text);
          sb[i] = '3';
          text = sb.ToString();
        }else if(text[i] == 'o'){
            StringBuilder sb = new StringBuilder(text);
            sb[i] = '0';
            text = sb.ToString();
          }else if(text[i] == 'I'){
              StringBuilder sb = new StringBuilder(text);
              sb[i] = '1';
              text = sb.ToString();
            }else if(text[i] == 't'){
                StringBuilder sb = new StringBuilder(text);
                sb[i] = '7';
                text = sb.ToString();
              }
            }
      for (int i = 1; i < text.Length; i++)
      {
        if(text[i] == 's' && text[i -1] != ' ' && text[i -1] != '\''){
          StringBuilder sb = new StringBuilder(text);
          sb[i] = 'z';
          text = sb.ToString();
        }
      }
      return text;
    }
  }
}
