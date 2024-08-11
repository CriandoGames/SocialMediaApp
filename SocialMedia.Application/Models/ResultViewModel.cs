namespace SocialMedia.Application.Models
{
    public class ResultViewModel
    {
        public ResultViewModel(string message = "", bool isSuccess = true)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public static ResultViewModel Success()
            => new();

        public static ResultViewModel Error(string message)
            => new(message, false);
    }

    public class ResultViewModel<T> : ResultViewModel
    {
        public ResultViewModel(T? data, string message = "", bool isSuccess = true)
            : base(message, isSuccess)
        {
            Data = data;
        }
        public T? Data { get; set; }

        public static ResultViewModel<T> Success(T data)
            => new(data);

        public static ResultViewModel<T> Error(string message)
            => new(default, message, false);
    }
}
