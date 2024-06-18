using System;

public interface IMetadata
{
    public DateTime Created { get; set; }

    public DateTime Edited { get; set; }


    public string Description { get; set; }

    public string Name { get; set; }

}