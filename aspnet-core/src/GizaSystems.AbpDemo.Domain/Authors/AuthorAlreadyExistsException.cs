using Volo.Abp;

namespace GizaSystems.AbpDemo.Authors
{ // BusinessException is a special exception type. It is a good practice to throw domain related exceptions when needed.
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
            // WithData(...) method is used to provide additional data to the exception object that will later be used
            // on the localization message or for some other purpose.
        }
    }
}
