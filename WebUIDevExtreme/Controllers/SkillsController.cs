using Core.Entities;
using Core.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace WebUIDevExtreme.Controllers
{
    public class SkillsController : BaseController<Skills>
    {
        public SkillsController(IUnitOfWork<Skills> context) : base(context)
        {
        }
    }
}
