using com.authright.saml2.Schema.Core;

namespace com.authright.saml2.Validation
{
    interface ISaml20SubjectValidator
    {
        void ValidateSubject(Subject subject);
    }
}