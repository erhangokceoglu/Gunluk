using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Gunluk.DATA
{
    public class Gonderi
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Baslik { get; set; } = null!;

        public string? Icerik { get; set; } = null!;

        [MaxLength(255)]
        public string? Resim { get; set; }

        public DateTime OlusturulmaZamani { get; set; } = DateTime.Now;

        public DateTime DegistirilmeZamani { get; set; } = DateTime.Now;

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; } = null!;
    }
}
