using FocusCFeMFeApi.Dtos;
using FocusCFeMFeApi.Models;
using System.Threading.Tasks;

namespace FocusCFeMFeApi.Interfaces
{
    public interface ICFeMFe
    {
        void EmitirCFe(CFeModel cfeMfe);
        void ConsultarStatusMFe();
    }
}
