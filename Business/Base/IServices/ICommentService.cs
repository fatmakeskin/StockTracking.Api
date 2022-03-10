using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base.IServices
{
    public interface ICommentService
    {
        CommentDto GetById(int id);
        IEnumerable<CommentDto> GetAll();
        void Add(CommentDto model);
        void Update(CommentDto model);
        void Delete(CommentDto model);
    }
}
