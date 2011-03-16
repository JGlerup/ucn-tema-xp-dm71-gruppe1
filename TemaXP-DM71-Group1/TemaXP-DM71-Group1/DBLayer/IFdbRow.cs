using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFdbRow
    {
        void InsertRow(Row row);

        void DeleteRow(Row row);

        void UpdateRow(Row row);

        Row FindRowByRowNoAndCinema(int rowNo, Cinema cinema, bool retrieveAssociation);

        Row FindRowById(Row row, bool retrieveAssociation);

        IList<Row> FindAllRows(bool retrieveAssociation);
    }
}
