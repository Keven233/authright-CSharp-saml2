using com.authright.saml2.Schema.Core;
using com.authright.saml2.Schema.Protocol;

namespace com.authright.saml2.Validation
{
    internal interface ISaml20AttributeValidator
    {
        void ValidateAttribute(SamlAttribute samlAttribute);
        void ValidateEncryptedAttribute(EncryptedElement encryptedElement);
    }
}