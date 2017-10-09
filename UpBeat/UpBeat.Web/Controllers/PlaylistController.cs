﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpBeat.Services.Contracts;
using UpBeat.Web.Models;

namespace UpBeat.Web.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAlbumService albumService;

        public PlaylistController(IMapper mapper, IAlbumService albumService)
        {
            this.mapper = mapper;
            this.albumService = albumService;
        }

        // GET: Playlist
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult All()
        {
            var dbAlbums = this.albumService.GetAll()
                .Select(x => this.mapper.Map<AlbumViewModel>(x))
                .ToList();

            var playlistViewModel = new PlaylistViewModel() { Albums = dbAlbums };

            return View("Index", playlistViewModel);
        }
    }
}