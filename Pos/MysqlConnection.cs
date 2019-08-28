namespace Pos
{
    internal class MysqlConnection
    {
        private string strConn;

        public MysqlConnection(string strConn)
        {
            this.strConn = strConn;
        }
    }
}