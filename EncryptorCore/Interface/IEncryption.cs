using System.Threading.Tasks;

namespace EncryptorCore.Interface
{
    public interface IEncryption
    {
        string EncryptWord(string inputWord);
        string EncryptText(string inputText);
    }
}