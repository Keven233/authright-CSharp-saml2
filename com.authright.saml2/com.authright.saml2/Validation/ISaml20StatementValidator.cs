using com.authright.saml2.Schema.Core;

namespace com.authright.saml2.Validation
{
    internal interface ISaml20StatementValidator
    {
        void ValidateStatement(StatementAbstract statement);
    }
}