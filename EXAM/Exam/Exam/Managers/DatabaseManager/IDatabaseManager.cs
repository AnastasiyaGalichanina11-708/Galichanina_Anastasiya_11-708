using System.Collections.Generic;
using Exam.Features.Identity.Models;
using Exam.Models;

namespace Exam.Managers.DatabaseManager
{
    public interface IDatabaseManager
    {
        #region User

        ApplicationUser GetUser(string email);

        void EditUser(string email, ApplicationUser newUser);


        #endregion

        #region Recipe


        List<File> GetFilesByShortComment(string status);

        IEnumerable<File> GetUserFiles(string userEmail);

        File GetFile(int id);

        void AddFile(File file);

        void EditFile(File file);

        void DeleteFile(int id, bool isAdmin, string email);

        #endregion


    }
}