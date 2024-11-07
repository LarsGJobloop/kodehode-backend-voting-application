class Election
{
  public Guid id;
  public List<ElectionOption> options;
  public List<Vote> castVotes;

  public Election(List<ElectionOption> electionOptions)
  {
    if (electionOptions.Count <= 1)
    {
      throw new ArgumentException("An election needs atleast 2 options"); ;
    }

    options = electionOptions;
    castVotes = new List<Vote>();
    id = Guid.NewGuid();
  }
}
