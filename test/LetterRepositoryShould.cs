﻿using Diamonds.Domain;

namespace Diamonds.Test;

public class LetterRepositoryShould
{
    private readonly LetterRepository _letterRepository = new();
    [Fact]
    public void GetLettersUpTo()
    {
        Assert.Equal("A", string.Join(",", _letterRepository.GetUpTo("A")));
    }
}