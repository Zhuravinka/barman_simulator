using System;

public class GameManager : Singleton<GameManager>
{
    public static event Action Started = delegate { };

    public bool IsStarted { get; private set; }
    public bool IsFinished { get; private set; }
}
