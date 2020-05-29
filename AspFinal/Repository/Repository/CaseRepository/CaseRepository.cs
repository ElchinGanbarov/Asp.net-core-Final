using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository.CaseRepository
{
    public interface ICaseRepository
    {
        CaseStudiesSingle GetStudiesTrue();
        IEnumerable<Solution> GetSolutions(int count);
        IEnumerable<CaseStudiesSingle> GetCaseStudiesFull();
        CaseStudiesSingle AddCasesStudies(CaseStudiesSingle cases);
        CaseStudiesSingle GetCasesById(int id);
        void UpdateCases(CaseStudiesSingle updateCase, CaseStudiesSingle cases);
        void RemoveCases(CaseStudiesSingle cases);
        IEnumerable<CaseStudiesSpec> GetFullCaseSpecs();
        CaseStudiesSpec CreateCaseSpecs(CaseStudiesSpec model);
        IEnumerable<FAQ> GetFaqsFull();
        IEnumerable<Solution> GetFullsSOlition();
        CaseStudiesSpec GetCaseSpecsById(int id);
        void UpdateCaseSpecs(CaseStudiesSpec updateCasespecs, CaseStudiesSpec model);
        void RemoveCasespecsId(CaseStudiesSpec casespecs);
        FAQ FaqCreate(FAQ model);
        FAQ GetFaqsById(int id);
        void UpdateFaq(FAQ updatefaq, FAQ model);
        void RemoveFaqs(FAQ faqs);
        Solution SolutionCreat(Solution model);
        Solution GetSolutionById(int id);
        void UpdateSolution(Solution updatesolution, Solution model);
        void RemoveSolution(Solution solution);
    }
    public class CaseRepository : ICaseRepository
    {
        private readonly JotexDbContext _context;
        public CaseRepository(JotexDbContext context)
        {
            _context = context;
        }

        public CaseStudiesSingle AddCasesStudies(CaseStudiesSingle cases)
        {
            _context.CaseStudiesSingles.Add(cases);
            _context.SaveChanges();
            return cases;
        }

        public CaseStudiesSpec CreateCaseSpecs(CaseStudiesSpec model)
        {
            _context.CaseStudiesSpecs.Add(model);
            _context.SaveChanges();
            return model;
        }

        public FAQ FaqCreate(FAQ model)
        {
            _context.FAQs.Add(model);
            _context.SaveChanges();
            return model;
        }

        public CaseStudiesSingle GetCasesById(int id)
        {
            return _context.CaseStudiesSingles.Find(id);
        }

        public CaseStudiesSpec GetCaseSpecsById(int id)
        {
            return _context.CaseStudiesSpecs.Find(id);
        }

        public IEnumerable<CaseStudiesSingle> GetCaseStudiesFull()
        {
            return _context.CaseStudiesSingles.ToList();
        }

        public FAQ GetFaqsById(int id)
        {
            return _context.FAQs.Find(id);
        }

        public IEnumerable<FAQ> GetFaqsFull()
        {
            return _context.FAQs.ToList();
        }

        public IEnumerable<CaseStudiesSpec> GetFullCaseSpecs()
        {
            return _context.CaseStudiesSpecs.Include(c=>c.CaseStudiesSingle).ToList();
        }

        public IEnumerable<Solution> GetFullsSOlition()
        {
            return _context.Solutions.ToList();
        }

        public Solution GetSolutionById(int id)
        {
            return _context.Solutions.Find(id);
        }

        public IEnumerable<Solution> GetSolutions(int count)
        {
            return _context.Solutions.Where(b => b.Status).Take(count).ToList();
        }

        public CaseStudiesSingle GetStudiesTrue()
       {
            return _context.CaseStudiesSingles.Include(b => b.CaseStudiesSpecs).Where(b=>b.Status).FirstOrDefault();
        }

        public void RemoveCases(CaseStudiesSingle cases)
        {
            _context.CaseStudiesSingles.Remove(cases);
            _context.SaveChanges();
        }

        public void RemoveCasespecsId(CaseStudiesSpec casespecs)
        {
            _context.CaseStudiesSpecs.Remove(casespecs);
            _context.SaveChanges();
        }

        public void RemoveFaqs(FAQ faqs)
        {
            _context.FAQs.Remove(faqs);
            _context.SaveChanges();
        }

        public void RemoveSolution(Solution solution)
        {
            _context.Solutions.Remove(solution);
            _context.SaveChanges();
        }

        public Solution SolutionCreat(Solution model)
        {
            _context.Solutions.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void UpdateCases(CaseStudiesSingle updateCase, CaseStudiesSingle cases)
        {
            updateCase.Status = cases.Status;
            updateCase.Title = cases.Title;
            updateCase.Text = cases.Text;
            updateCase.Subtitle = cases.Subtitle;
            updateCase.Image = cases.Image;
            _context.SaveChanges();
        }

        public void UpdateCaseSpecs(CaseStudiesSpec updateCasespecs, CaseStudiesSpec model)
        {
            updateCasespecs.Status = model.Status;
            updateCasespecs.CaseStudiesSingleId = model.CaseStudiesSingleId;
            updateCasespecs.Key = model.Key;
            updateCasespecs.Value = model.Value;
            _context.SaveChanges();
        }

        public void UpdateFaq(FAQ updatefaq, FAQ model)
        {
            updatefaq.Status = model.Status;
            updatefaq.Answer = model.Answer;
            updatefaq.Question = model.Question;
            _context.SaveChanges();

        }

        public void UpdateSolution(Solution updatesolution, Solution model)
        {
            updatesolution.Status = model.Status;
            updatesolution.Key = model.Key;
            updatesolution.Value = model.Value;
            _context.SaveChanges();

        }
    }
}
