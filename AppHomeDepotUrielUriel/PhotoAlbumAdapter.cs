using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace AppHomeDepotUrielUriel
{
    public class PhotoAlbumAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> SeleccionElemento;
        public AlbumFotos mAlbumFotos;
        string[] items;

        public PhotoAlbumAdapter(AlbumFotos AlbumFotos)
        {
            mAlbumFotos = AlbumFotos;
        }


        public override RecyclerView.ViewHolder
            OnCreateViewHolder(ViewGroup Contenido, int viewType)
        {
            View VistaDeElemento = LayoutInflater.From(Contenido.Context).
            Inflate(Resource.Layout.PhotoCardLayout, Contenido, false);
            var vh = new PhotoViewHolder(VistaDeElemento, OnClick);
            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder cabecera, int posicion)
        {
            PhotoViewHolder pvh = cabecera as PhotoViewHolder;
            pvh.Imagen.SetImageResource(mAlbumFotos[posicion].FotoID);
            

        }

        public override int ItemCount
        {
            get { return mAlbumFotos.CantidadDeFotos; }
        }
        void OnClick(int position)
        {
            SeleccionElemento(this, position);
        }
    }
    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Imagen { get; private set; }
        public TextView Texto { get; private set; }
        public PhotoViewHolder(View Elemento, Action<int> Colocador) : base(Elemento)
        {
            Imagen = Elemento.FindViewById<ImageView>(Resource.Id.imagen);
          
            Elemento.Click += (sender, e) => Colocador(base.LayoutPosition);
        }
    }
}