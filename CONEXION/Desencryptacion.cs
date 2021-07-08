using System.Xml;


namespace MD_LOGIN.CONEXION

{
    class Desencryptacion
    {
        static private AES aes = new AES();
        static public string CnString;
        static string dbcnString;
        static public string appPwdUnique = "3sisj#45asdjpJOPFSD365%&.09-*ÑAED.99?¡}{+";


        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
        //public static object checkServerWEB()
        //{
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load("ConnectionString.xml");
        //    XmlElement root = doc.DocumentElement;
        //    dbcnString = root.Attributes[0].Value;
        //    CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
        //    return CnString;

        //}
        internal class label
        {

        }
        public static object UsuariosEncryp()
        {
            XmlDocument doc = new XmlDocument();
            label root = new label();

            dbcnString = root.ToString();
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
    }

}
