# PoC_PaintingCycling


## Introduction

This project aimed at having the first iteration of one of our component.
It consist of a single painting, that cycle in between differents arts pieces.

[![See video by clicking here](http://img.youtube.com/vi/xK1P5L9zRUM/0.jpg)](http://www.youtube.com/watch?v=xK1P5L9zRUM)

The idea being to have one asset that we can work on to tweak.

__**Remainder:**__ This was made as part of a student project. Stability ain't ensured.

#
#

## Getting Started

### Prerequisites

* [Unity 5.1.2+](https://unity3d.com/fr), 3D environnement.

### How it works

The painting contain a C# script component that apply a new texture programmatically every **n** seconds.
This texture is randomly picked and download from a **file** containing directs links to art pictures.
Both these **parameter** can be informed in the component itself.

The process that gather and change the painting is a coroutine function for optimisations reasons.

## Credits

Free communities assets were used:

* [Clod's skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-4183
), for the skyBox.

* [3DFancy's Stone Floor Texture Tile](https://assetstore.unity.com/packages/2d/textures-materials/roads/stone-floor-texture-tile-18683), A texture for the pedestal.

* [Webcadabra's Paintings Free](https://assetstore.unity.com/packages/3d/props/interior/paintings-free-44185), for the frame of the paintings.


## Authors

* **Posnic Antoine** - *Initial work* - [PosnicAntoine](https://github.com/PosnicAntoine)
