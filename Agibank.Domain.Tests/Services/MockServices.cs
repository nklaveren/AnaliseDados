﻿using Agibank.Domain.Interfaces;
using Agibank.Domain.Services;

using Microsoft.Extensions.FileProviders;

using System.IO;

namespace Agibank.Domain.Tests.Services
{
    static class MockServices
    {
        private static PhysicalFileProvider fileProvider;
        private static IArquivoService arquivoService;

        private static readonly IFileProvider FileProvider = fileProvider ??= new PhysicalFileProvider(Directory.GetCurrentDirectory());
        internal static IArquivoService ArquivoService => arquivoService ??= new ArquivoService(FileProvider);

        internal static IProcessaArquivoService ProcessaArquivoService => new ProcessaArquivoService(AnaliseVendasService, arquivoService);

        internal static AnaliseVendasRelatorioService AnaliseVendasService => new AnaliseVendasRelatorioService();
    }
}
