using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FormCadastro.DAL;
using FormCadastro.Models;
using Newtonsoft.Json;

namespace FormCadastro.Controllers
{
    public class CadastroController : Controller
    {
        private readonly BancoContext _context;

        public CadastroController(BancoContext context)
        {
            _context = context;
        }

        // GET: Cadastro
        public async Task<IActionResult> Index()
        {
            return View(await _context.TB_CADASTRO.ToListAsync());
        }

        // GET: Cadastro/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.TB_CADASTRO == null)
            {
                return NotFound();
            }

            var tB_CADASTRO = await _context.TB_CADASTRO
                .FirstOrDefaultAsync(m => m.ID_REGISTRO == id);
            if (tB_CADASTRO == null)
            {
                return NotFound();
            }

            return View(tB_CADASTRO);
        }

        // GET: Cadastro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TB_CADASTRO tB_CADASTRO)
        {
            if (ModelState.IsValid)
            {
                var nro_inscricao = 0;
                try
                {
                    nro_inscricao = _context.TB_CADASTRO.Max(x => x.NRO_INSCRICAO);
                }
                catch
                {
                    nro_inscricao = 1;
                }
                
                tB_CADASTRO.ID_REGISTRO = Guid.NewGuid();
                tB_CADASTRO.NRO_INSCRICAO = nro_inscricao;
                tB_CADASTRO.DATA_INSCRICAO = DateTime.Now;
                _context.Add(tB_CADASTRO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tB_CADASTRO);
        }

        // GET: Cadastro/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.TB_CADASTRO == null)
            {
                return NotFound();
            }

            var tB_CADASTRO = await _context.TB_CADASTRO.FindAsync(id);
            if (tB_CADASTRO == null)
            {
                return NotFound();
            }
            return View(tB_CADASTRO);
        }

        // POST: Cadastro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID_REGISTRO,NRO_INSCRICAO,DATA_INSCRICAO,NOME_TIT,NASC_TIT,RG_TIT,CPF_TIT,EST_CIVIL_TIT,SEXO_TIT,NATURAL_TIT,NESC_ESP_TIT,NESC_ESP_TIT_DESCRICAO,NOME_MAE,ENDERECO,ENDERECO_NRO,ENDERECO_COMP,BAIRRO,CEP,MUNICIPIO,TELEFONE_RES,TELEFONE_CEL,EMPRESA_TIT,PROF_TIT,RENDA_TIT,END_COMERCIAL_TIT,NRO_COMERCIAL_TIT,BAIRRO_COMERCIAL_TIT,CEP_COMERCIAL_TIT,MUNI_COMERCIAL_TIT,NOME_CON,NASC_CON,RG_CON,CPF_CON,EST_CIVIL_CON,SEXO_CON,NATURAL_CON,NESC_ESP_CON,NESC_ESP_CON_DESCRICAO,EMPRESA_CON,PROF_CON,RENDA_CON,END_COMERCIAL_CON,NRO_COMERCIAL_CON,BAIRRO_COMERCIAL_CON,CEP_COMERCIAL_CON,MUNI_COMERCIAL_CON,DEP1_NOME,DEP1_PAREN,DEP1_NASC,DEP1_RENDA,DEP2_NOME,DEP2_PAREN,DEP2_NASC,DEP2_RENDA,DEP3_NOME,DEP3_PAREN,DEP3_NASC,DEP3_RENDA,DEP4_NOME,DEP4_PAREN,DEP4_NASC,DEP4_RENDA,DEP5_NOME,DEP5_PAREN,DEP5_NASC,DEP5_RENDA,DEP6_NOME,DEP6_PAREN,DEP6_NASC,DEP6_RENDA,DEP7_NOME,DEP7_PAREN,DEP7_NASC,DEP7_RENDA,DEP8_NOME,DEP8_PAREN,DEP8_NASC,DEP8_RENDA,DEP9_NOME,DEP9_PAREN,DEP9_NASC,DEP9_RENDA,DEP10_NOME,DEP10_PAREN,DEP10_NASC,DEP10_RENDA,DEP11_NOME,DEP11_PAREN,DEP11_NASC,DEP11_RENDA")] TB_CADASTRO tB_CADASTRO)
        {
            if (id != tB_CADASTRO.ID_REGISTRO)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tB_CADASTRO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TB_CADASTROExists(tB_CADASTRO.ID_REGISTRO))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tB_CADASTRO);
        }

        // GET: Cadastro/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.TB_CADASTRO == null)
            {
                return NotFound();
            }

            var tB_CADASTRO = await _context.TB_CADASTRO
                .FirstOrDefaultAsync(m => m.ID_REGISTRO == id);
            if (tB_CADASTRO == null)
            {
                return NotFound();
            }

            return View(tB_CADASTRO);
        }

        // POST: Cadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.TB_CADASTRO == null)
            {
                return Problem("Entity set 'BancoContext.TB_CADASTRO'  is null.");
            }
            var tB_CADASTRO = await _context.TB_CADASTRO.FindAsync(id);
            if (tB_CADASTRO != null)
            {
                _context.TB_CADASTRO.Remove(tB_CADASTRO);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TB_CADASTROExists(Guid id)
        {
          return (_context.TB_CADASTRO?.Any(e => e.ID_REGISTRO == id)).GetValueOrDefault();
        }

        public Address GetCEP([FromQuery] string CEP)
        {
            HttpClient client = new HttpClient();

            var response = client.GetAsync("https://viacep.com.br/ws/" + CEP + "/json/").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            

            if(response.IsSuccessStatusCode)
            {
                var jsonobject = JsonConvert.DeserializeObject<Address>(json);
                return jsonobject;
            }
            return null;
        }
    }
}
