using chen0040.ExpertSystem;

namespace ExpertSystem.Wealth.Engines;

public class WealthExpertSystem
{
    public RuleInferenceEngine getInferenceEngine()
	{
		RuleInferenceEngine es = new RuleInferenceEngine();

		var rule = new Rule("UpperClass");
		rule.AddAntecedent(new IsClause("HighIncomeProfession", "Yes"));
		rule.setConsequent(new Clause("Class", "UpperClass"));
		es.AddRule(rule);
		
		rule = new Rule("UpperClass");
		rule.AddAntecedent(new IsClause("BusinessOwnership", "Yes"));
		rule.setConsequent(new Clause("Class", "UpperClass"));
		es.AddRule(rule);
		
		rule = new Rule("UpperClass");
		rule.AddAntecedent(new IsClause("Investment", "Yes"));
		rule.setConsequent(new IsClause("Class", "UpperClass"));
		es.AddRule(rule);
		
		rule = new Rule("UpperMiddleClass");
		rule.AddAntecedent(new IsClause("HighEducation", "Yes"));
		rule.AddAntecedent(new IsClause("ManagerialProfession", "Yes"));
		rule.setConsequent(new IsClause("Class", "UpperMiddleClass"));

		es.AddRule(rule);
		
		rule = new Rule("MiddleClass");
		rule.AddAntecedent(new IsClause("StableJob", "Yes"));
		rule.setConsequent(new IsClause("Class", "MiddleClass"));
		es.AddRule(rule);
		
		rule = new Rule("MiddleClass");
		rule.AddAntecedent(new IsClause("HighEducation", "Yes"));
		rule.setConsequent(new IsClause("Class", "MiddleClass"));
		es.AddRule(rule);
		
		rule = new Rule("MiddleClass");
		rule.AddAntecedent(new IsClause("Education", "Yes"));
		rule.setConsequent(new IsClause("Class", "MiddleClass"));
		es.AddRule(rule);
		
		rule = new Rule("LowerClass");
		rule.AddAntecedent(new IsClause("NormalJob", "Yes"));
		rule.setConsequent(new IsClause("Class", "LowerClass"));
		es.AddRule(rule);
		
		rule = new Rule("WorkingClass");
		rule.AddAntecedent(new IsClause("LaborJob", "Yes"));
		rule.setConsequent(new IsClause("Class", "WorkingClass"));
		es.AddRule(rule);
		
		rule = new Rule("WorkingClass");
		rule.AddAntecedent(new IsClause("Education", "No"));
		rule.setConsequent(new IsClause("Class", "WorkingClass"));
		es.AddRule(rule);

		rule = new Rule("Poor");
		rule.AddAntecedent(new IsClause("UnEmployed", "Yes"));
		rule.setConsequent(new IsClause("Class", "Poor"));
		es.AddRule(rule);
		
		rule = new Rule("Poor");
		rule.AddAntecedent(new IsClause("Education", "No"));
		rule.setConsequent(new IsClause("Class", "Poor"));
		es.AddRule(rule);
		return es;
	}
}