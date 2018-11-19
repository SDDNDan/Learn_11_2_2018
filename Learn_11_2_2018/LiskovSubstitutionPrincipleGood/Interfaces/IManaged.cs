using LiskovSubstitutionPrincipleGood.Models;

namespace LiskovSubstitutionPrincipleGood.Interfaces
{
    public interface IManaged
    {
        BaseEmployee HisManager { get; set; }

        void AssignManager(BaseEmployee manager);
    }
}
