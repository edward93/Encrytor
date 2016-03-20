using System.Threading.Tasks;

namespace EncryptorCore.Interface
{
    public interface IDecryption
    {
        string DecryptWord(string inputWord);
        string DecryptText(string inputText);
    }
}