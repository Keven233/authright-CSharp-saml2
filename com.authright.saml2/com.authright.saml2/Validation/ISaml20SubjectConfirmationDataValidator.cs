using com.authright.saml2.Schema.Core;

namespace com.authright.saml2.Validation
{
    internal interface ISaml20SubjectConfirmationDataValidator
    {
        void ValidateSubjectConfirmationData(SubjectConfirmationData data);
    }
}