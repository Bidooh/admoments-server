using AdMoments.Domain.Interfaces;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace AdMoments.Business.ImageProcessing
{
    public class SetBackgroundColourOperation : IImageOperation
    {
        private readonly Rgba32 _bgColour;

        public SetBackgroundColourOperation(Rgba32 bgColour)
        {
            _bgColour = bgColour;
        }

        public Image<Rgba32> Apply(Image<Rgba32> inImage)
        {
            inImage.Mutate(i => i.BackgroundColor(_bgColour));
            return inImage;
        }
    }
}
