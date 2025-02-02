using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TechDM.Server.Database;
using TechDM.Shared;
using TechDM.Shared.Enums;

namespace TechDM.Server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        
        private readonly ApplicationDbContext _context;

        public QuestionController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        // GET: api/question
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // var questionList = await _context.Questions.ToListAsync();

            List<Question> questionList;
            
            using (StreamReader r = new StreamReader("./ShownQuestionList.json"))
            {
                string json = r.ReadToEnd();
                questionList = JsonConvert.DeserializeObject<List<Question>>(json);
            }
            
            return Ok(questionList);
        }
        
        // GET: api/question/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var question = await _context.Questions.FirstOrDefaultAsync(c=>c.Id == id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }
        
        
        // POST: api/question
        [HttpPost]
        public async Task<IActionResult> Post(Question question)
        {
            _context.Add(question);
            await _context.SaveChangesAsync();
            return Ok(question.Id); 
        }
        
        // PUT: api/question
        [HttpPut]
        public async Task<IActionResult> Put(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        
        //DELETE: api/question/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var question = new Question() { Id = id };
            _context.Remove(question);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}