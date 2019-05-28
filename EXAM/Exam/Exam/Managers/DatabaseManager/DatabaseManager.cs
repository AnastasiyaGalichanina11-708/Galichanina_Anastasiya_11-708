using System;
using System.Collections.Generic;
using System.Linq;
using Exam.Data;
using Exam.Features.Identity.Models;
using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Managers.DatabaseManager
{
    public class DatabaseManager: IDatabaseManager
    {
        private readonly MyDBContext _databaseContext;

        public DatabaseManager(MyDBContext context) => _databaseContext = context;

        #region User

        public ApplicationUser GetUser(string email)
        {
            var user = _databaseContext.Users.FirstOrDefault(u => u.UserName == email);
            return user ?? throw new Exception("No user with given id");
        }

        public void EditUser(string email, ApplicationUser newUser)
        {
            var oldUser = GetUser(email);
            if (newUser.PhoneNumber != null)
                oldUser.PhoneNumber = newUser.PhoneNumber;
            _databaseContext.SaveChanges();
        }

        #endregion

        //#region File

        private List<File> GetFilesByPredicate(Func<File, bool> predicate)
        {
            return _databaseContext
                .Files
                .Where(recipe => predicate(recipe))
                .OrderByDescending(article => article.CreationDate)
                .ToList();
        }



        public List<File> GetFilesByShortComment(string status) =>
            GetFilesByPredicate(recipe =>
                recipe.ShortComment == status);

        public IEnumerable<File> GetUserFiles(string userEmail) =>
            GetFilesByPredicate(a => a.Username == userEmail);

        public File GetFile(int id)
        {
            var file = _databaseContext.Files.FirstOrDefault(a => a.Id == id);
            if (file == default(File))
                throw new Exception("No file with given id");
            return file;
        }

        public void AddFile(File file)
        {
            if (file == default(File))
                throw new Exception("No File with given id");
            _databaseContext.Files.Add(file);
            _databaseContext.SaveChanges();
        }

        public void EditFile(File file)
        {
            var oldRecipe = _databaseContext.Files.FirstOrDefault(a => a.Id == file.Id);
            if (oldRecipe == default(File))
                throw new Exception("No File with given id");
            oldRecipe.Title = file.Title;
            oldRecipe.Content = file.Content;
            oldRecipe.ShortComment = file.ShortComment;
            _databaseContext.SaveChanges();
        }



        public void DeleteFile(int id, bool isAdmin, string email)
        {
            var recipe = GetFile(id);
            if (recipe != default(File) && isAdmin || recipe != default(File))
            {
                _databaseContext.Files.Remove(recipe);
                
                _databaseContext.SaveChanges();
            }
        }
    }
}
