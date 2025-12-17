using Autofac;
using SixLabors.ImageSharp;
using TagCloud.Colors;
using TagCloud.Layouters;
using TagCloud.Sizing;
using TagCloud.Visualizers;
using TagCloud.WordsProcessing;
using TagCloud.WordsProviders;

namespace TagCloud.Client.DI;

public class TagCloudModule(string? boringWordsPath) : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<WordsProvider>()
            .As<IWordsProvider>()
            .SingleInstance();
        builder.RegisterType<WordLowercaser>()
            .As<IWordNormalizer>()
            .SingleInstance();
        builder.Register(ctx =>
            {
                var wordsProvider = ctx.Resolve<IWordsProvider>();
                return new BoringWordsProvider(boringWordsPath, wordsProvider);
            })
            .As<IBoringWordsProvider>()
            .SingleInstance();
        builder.RegisterType<BoringWordsFilter>()
            .As<IWordFilter>()
            .SingleInstance();
        builder.RegisterType<WordProcessor>()
            .As<IWordProcessor>()
            .SingleInstance();
        builder.RegisterType<FrequencyCounter>()
            .As<IFrequencyCounter>()
            .SingleInstance();
        builder.RegisterType<FontSizeCalculator>()
            .As<IFontSizeCalculator>()
            .SingleInstance();
        builder.RegisterType<TextTagSizeCalculator>()
            .As<ITextTagSizeCalculator>()
            .SingleInstance();
        builder.RegisterType<CircularCloudLayouterFactory>()
            .As<ICircularCloudLayouterFactory>()
            .SingleInstance();
        builder.RegisterInstance(new WordColorizer(Color.DarkBlue))
            .As<IWordColorizer>();
        builder.RegisterInstance(new TagCloudVisualizer(Color.AntiqueWhite))
            .As<ITagCloudVisualizer>();
        builder.RegisterType<TagCloudGenerator>()
            .As<ITagCloudGenerator>()
            .SingleInstance();
    }
}