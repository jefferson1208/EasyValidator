using System.Collections.Generic;
using System.Linq;

namespace EasyValidator.Validator.Errors
{
    public abstract class Notify<T> where T : Error
    {
        private readonly List<Error> _errors;

        protected Notify() { _errors = new List<Error>(); }

        public IReadOnlyCollection<Error> Errors =>
            new List<Error>(_errors);

        public void AddError(string message)
        {
            _errors.Add(new Error(message));
        }

        public void AddError(Error error)
        {
            _errors.Add(error);
        }

        public void AddErrors(IReadOnlyCollection<Error> errors)
        {
            _errors.AddRange(errors);
        }

        public void AddErrors(IList<Error> errors)
        {
            _errors.AddRange(errors);
        }

        public void AddErrors(ICollection<Error> errors)
        {
            _errors.AddRange(errors);
        }

        public void AddErrors(Notify<T> item)
        {
            AddErrors(item.Errors);
        }

        public void AddErrors(params Notify<T>[] items)
        {
            foreach (var item in items)
                AddErrors(item);
        }

        protected virtual IEnumerable<Error> Validations() => null;

        private IEnumerable<Error> GetNotificationsFromValidations()
        {
            return Validations() ?? new List<Error>();
        }

        public bool Valid => !_errors.Any() || GetNotificationsFromValidations().Any();

    }
}
