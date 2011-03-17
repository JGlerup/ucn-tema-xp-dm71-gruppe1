using System.Collections.Generic;
using TemaXP_DM71_Group1_ServiceLib.ModelLayer;

namespace TemaXP_DM71_Group1_ServiceLib.DBLayer
{
    public interface IFdbRow
    {
        void InsertRow(Row row);

        void DeleteRow(Row row);

        void UpdateRow(Row row);

        Row FindRowByRowNoAndCinema(int rowNo, Cinema cinema, bool retrieveAssociation);

        Row FindRowById(Row row, bool retrieveAssociation);

        IList<Row> FindRowsByCinemaId(Cinema c, bool retrieveAssociation);

        IList<Row> FindAllRows(bool retrieveAssociation);
    }
}
