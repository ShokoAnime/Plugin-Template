# Shoko Plugin Template

A bare Shoko Server plugin that builds, loads and releases, with nothing else
in it. For examples of what a plugin can do, see the
[sample plugins](https://github.com/ShokoAnime/SamplePlugins) and the
[plugin documentation](https://docs.shokoanime.com/daily/writing-plugins/getting-started).

## Making it yours

1. Replace the placeholder ID `00000000-0000-0000-0000-000000000001` with a
   newly generated GUID, in both `manifest.json` (`id`) and `source/Plugin.cs`
   (`ID`). The two have to match, and no two plugins may share one.
2. Rename the plugin: `Name` in `source/Plugin.cs`, `name`, `overview`,
   `authors` and `repository_url` in `manifest.json`, and the project,
   solution and namespace if you like.
3. Build it with `dotnet build`, and copy the output folder into the server's
   `plugins` folder to try it.

## Releasing

Releases are built by `.github/workflows/release.yml` when a GitHub release is
published.

1. Once, before the first release: create a branch named `metadata` holding a
   copy of `manifest.json` with your real identity filled in. The workflow
   adds each release to that copy; the one on your main branch stays a stub.
2. Bump `<Version>` in the `.csproj`, then publish a release tagged
   `v<Version>`, e.g. `v1.0.0`.

To offer the plugin to users, point a plugin repository at the raw
`manifest.json` on the `metadata` branch.
