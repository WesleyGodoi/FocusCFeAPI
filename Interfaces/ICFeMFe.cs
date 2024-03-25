using FocusCFeMFeApi.Dtos;
using FocusCFeMFeApi.Models;
using System.Threading.Tasks;

namespace FocusCFeMFeApi.Interfaces
{
    public interface ICFeMFe
    {
        CFeModel DadosCfe { get; set; }
        void EmitirCFe(CFeModel cfeMfe);
        void CancelarCFe(CFeModel cfeMfe);
        void ConsultarCFe(CFeModel cfeMfe);
        void ConsultarStatusMFe(CFeModel cfeMfe);
    }
}
