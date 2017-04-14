using com.authright.saml2.Schema.Core;
using com.authright.saml2.Schema.Protocol;

namespace com.authright.saml2.Validation
{
    internal interface ISaml20NameIDValidator
    {
        void ValidateNameID(NameID nameID);
        void ValidateEncryptedID(EncryptedElement encryptedID);
    }
}