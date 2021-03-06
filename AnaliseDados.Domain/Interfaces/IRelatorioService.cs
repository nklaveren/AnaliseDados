﻿using System;

namespace AnaliseDados.Domain.Interfaces
{
    public interface IRelatorioService : IDisposable
    {
        void Adicionar(string item);

        IRelatorio Processar();

        string RelatorioExtensao { get; }
    }
}
