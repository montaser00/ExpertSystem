

using chen0040.ExpertSystem;
using ExpertSystem.Wealth.Engines;

var es = new WealthExpertSystem().getInferenceEngine();

es.AddFact(new IsClause("Investment", "Yes"));
es.AddFact(new IsClause("HighEducation", "Yes"));
es.AddFact(new IsClause("ManagerialProfession", "Yes"));

Console.WriteLine("before inference");
Console.WriteLine("{0}", es.Facts);
Console.WriteLine("");

es.Infer(); //forward chain

Console.WriteLine("after inference");
Console.WriteLine("{0}", es.Facts);
Console.WriteLine("");

var es2 = new WealthExpertSystem().getInferenceEngine();

es2.AddFact(new IsClause("Education", "No"));
es2.AddFact(new IsClause("StableJob", "Yes"));

Console.WriteLine("before inference");
Console.WriteLine("{0}", es2.Facts);
Console.WriteLine("");

es2.Infer();

Console.WriteLine("after inference");
Console.WriteLine("{0}", es2.Facts);
Console.WriteLine("");

var es3  = new WealthExpertSystem().getInferenceEngine();

es3.AddFact(new IsClause("UnEmployed", "Yes"));

Console.WriteLine("before inference");
Console.WriteLine("{0}", es3.Facts);
Console.WriteLine("");

es3.Infer();

Console.WriteLine("after inference");
Console.WriteLine("{0}", es3.Facts);
Console.WriteLine("");
