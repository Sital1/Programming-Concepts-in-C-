﻿namespace ProducerConsumer;

public interface IRead<T>
{
    Task<T> Read();
    bool IsComplete();
}