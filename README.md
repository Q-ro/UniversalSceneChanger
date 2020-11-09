# Ultimate Super Hyper Universal Scenechanger

 The Ultimate Super Hyper Universal Scene Scenechanger for Unity, is a small code tool that allows you to handle and centrallize the boring and oftem cumberson process of changing scenes and trasitioning by using cool looking animations. 


 ## Author :

Created by Andres Mrad (Q-ro)

 ## How to use :

The tool should be pretty self explanatory; just download the assets folder into your project's plugins folder (or wherever you feel like), and check the examples provided. 

### TL;DR :

To implement the tool you would basically have to add the provided scene changer helper prefab into your scene and call the provided method as such :

```CS

// Transition into scene by index
SceneTransitionHelper.ChangeScene(int scene, int transitionIndex, bool showLoading);

// Transition into scene by name
SceneTransitionHelper.ChangeScene(string scene, int transitionIndex, bool showLoading);

```

To sdd or modify your transitions you can do so by adding new game objects into the SceneTransitionHelper prefab (or modifying existing ones), and animate them to your liking.

 ## License :

 This project is provided under the Mozilla Public License Version 2.0.