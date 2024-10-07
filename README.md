# unofficial.osuframework.web
This repository is aimed to give osu!framework it's own webpage for more friendly visibility.

The pages are mostly generated using .NET's [docfx](https://dotnet.github.io/docfx) tool, while the wiki contents are ported from the [official repository's wiki section](https://github.com/ppy/osu-framework/wiki).

Please refer to [docfx's documentation](https://dotnet.github.io/docfx) to start contributing.

## Disclaimer
This repository is unofficial and may have outdated information. Contributions are welcomed to make it perfect!

osu!framework is licensed under [MIT License](https://opensource.org/licenses/MIT), [tl;dr](https://tldrlegal.com/license/mit-license) is you can do whatever you want as long as you include the original copyright and license notice in any copy of the software/source. Although this does not cover the usage of 'osu!' as it is under trademark protection.

## Dos and Don'ts
This section pretty much guides on contributing to it, assuming you already cloned this repository
### Do:
- Build your changes by running:
```
docfx build ./docfx.json
```
and host it locally by:
```
docfx serve ./_site --port 8080
```
(port flag is optional but it makes more clear where to navigate)
- Update table of contents when introducing new pages, or simply renames, by navigating into `toc.yml`, respective to the folder where your changes are made, which is yes, using [YAML](https://yaml.org/). Making a whole new category would require modifying the file in the root folder (as that's where the docfx.json file resides).

- Make a discussions thread if you have something in your mind, it'll get moved into issues if necessary!

### Don't:
-	Make changes to html file, as your changes won't last as soon as you rebuild your file. PLEASE only make changes directly to the source code's commenting or markdown files, for API references and wiki pages, respectively.

- Run `docfx ./docfx.json --serve` unless you have high end setups as this runs all 3 commands; `docfx metadata ./docfx.json`, `docfx build ./docfx` and `docfx serve ./_site` simultaneously which will be intensive, given the scale of the framework. Please run these commands separately instead.

- Use `id` when editing `toc.yml` files, as this would overly complicate things as requiring to edit `.manifest` files as well. Please use `href` instead.
 I don't see any benefits from this for now but any explanations are appreciated. Otherwise, I will take this part down.

