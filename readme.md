# Unity Singleton

A simple implementation of the singleton pattern with consideration for practical usecases.

## Usage

**GameSingleton**

`GameSingleton` is created once at game start and will never be destroyed. Simply create your singleton class by inheriting from `GameSingleton` and call `CreateInstance` like so:

```
    SoundManager.CreateInstance ();

    ...


    SoundManager.Instance.SomeMethod ();
```

`Instance` property has a very low performance cost because it does not check for null instance, unlike other singleton implementations.

**SceneSingleton**
`SceneSingleton` is an object that exists per scene basis. It can be preconfigured in the `Editor`. When switching scene, `SceneSingleton` will be destroyed, maybe leaving place for the another singleton of the same type in another scene.

```
    SceneManager.Instance.SomeMethod ();
```

Calling `Instance` property will find the singleton object in the scene at that moment. When switching scene, the singleton will be destroyed as normal and set `Instance` to null. Calling `Instance` again will access the singleton of the new scene.

A sample scene is also included.

To include Unity Singleton into your project, you can use `npm` method of unity package management described [here](https://github.com/minhhh/UBootstrap).

## Changelog

**0.0.1**

* Add `GameSingleton`, `SceneSingleton`

<br/>

