//>>built
define({common:{cancel:"\u53d6\u6d88",ok:"\u786e\u5b9a",details:"\u8be6\u7ec6\u4fe1\u606f",more:"\u66f4\u591a",arcgisOnline:"ArcGIS Online",continueConfirm:"\u7ee7\u7eed",rememberChoice:"\u4e0d\u518d\u8be2\u95ee",learnMore:"\u4e86\u89e3\u8be6\u7ec6\u4fe1\u606f",close:"\u5173\u95ed"},viewerPage:{title:"CityEngine Web Viewer",noWebSceneMsg:"\u672a\u6307\u5b9a\u4efb\u4f55 webscene\u3002",useUrlParameter:' \u4f7f\u7528 url \u53c2\u6570 "3dWebScene" \u6307\u5b9a ArcGIS Online \u9879\u76ee id \u6216\u672c\u5730 3ws \u6587\u4ef6\u6216\u5c06 .3ws \u6587\u4ef6\u62d6\u653e\u5230\u6b64\u5904',
ceWebViewerHelp:"CityEngine Web \u67e5\u770b\u5668\u5e2e\u52a9",ceWebViewerTroubleshooting:"CityEngine Web \u67e5\u770b\u5668\u7591\u96be\u89e3\u7b54",contactUs:"\u8054\u7cfb\u6211\u4eec",bypassWebglCheck:"\u7ed5\u8fc7 WebGL \u68c0\u6d4b\u68c0\u67e5",sceneReadyTime:"Web Scene \u51c6\u5907\u5c31\u7eea(${seconds} \u79d2)",webviewerVersion:"CE Web \u67e5\u770b\u5668\u7248\u672c",loadingWsId:"\u6b63\u5728\u52a0\u8f7d webscene id",loadingSceneFile:"\u6b63\u5728\u52a0\u8f7d\u573a\u666f\u6587\u4ef6",ieMsg:"\u60a8\u7684 Internet Explorer \u7248\u672c\u4e0d\u652f\u6301 WebGL\u3002\u60a8\u53ef\u80fd\u9700\u8981\u5347\u7ea7\u6d4f\u89c8\u5668\u6216\u4f7f\u7528\u5176\u4ed6\u6d4f\u89c8\u5668\u3002",
webglMinVersion:"\u6d4f\u89c8\u5668\u7684 WebGL \u7248\u672c\u4f4e\u4e8e CityEngine Web \u67e5\u770b\u5668\u6240\u8981\u6c42\u7684\u6700\u4f4e\u7248\u672c\u3002\u60a8\u53ef\u80fd\u9700\u8981\u5347\u7ea7\u6d4f\u89c8\u5668\u6216\u4f7f\u7528\u5176\u4ed6\u6d4f\u89c8\u5668\u3002",experimentalWebgl:"\u6d4f\u89c8\u5668\u7684 WebGL \u7248\u672c\u4f4e\u4e8e CityEngine Web \u67e5\u770b\u5668\u6240\u5efa\u8bae\u7684\u6700\u4f4e\u7248\u672c\uff0c\u4e00\u4e9b\u529f\u80fd\u53ef\u80fd\u65e0\u6cd5\u6b63\u5e38\u5de5\u4f5c\u3002",
featureNotSupported:"\u60a8\u7684\u6d4f\u89c8\u5668\u4e0d\u652f\u6301\u6b64\u529f\u80fd\u3002",safariMsg1:"\u5bf9\u4e8e Mac OSX \u4e0a\u7684 Safari\uff0c\u9700\u8981\u5728\u6d4f\u89c8\u5668\u4e2d\u542f\u7528 WebGL\u3002",safariMsg2:"\u5728\u6587\u4ef6 \x26rarr; \u9996\u9009\u9879 \x26rarr; \u9ad8\u7ea7\u4e2d\uff0c\u9009\u4e2d\x3cem\x3e\u5728\u83dc\u5355\u680f\u4e2d\u663e\u793a\u5f00\u53d1\u83dc\u5355\x3c/em\x3e\u3002",safariMsg3:"\u5728\u65b0\u542f\u7528\u7684\u5f00\u53d1\u83dc\u5355\u4e2d\uff0c\u542f\u7528 WebGL\u3002",
troubleMsg1:"\u8981\u67e5\u627e\u6709\u5173\u6d4f\u89c8\u5668 WebGL \u517c\u5bb9\u6027\u548c\u5176\u4ed6\u517c\u5bb9\u6d4f\u89c8\u5668\u7684\u8be6\u7ec6\u4fe1\u606f\uff0c\u8bf7\u8bbf\u95ee",troubleMsg2:'\x3ca href\x3d"http://get.webgl.org/troubleshooting" target\x3d"_blank"\x3eget.webgl.org/troubleshooting\x3c/a\x3e \u4ee5\u83b7\u53d6\u7591\u96be\u89e3\u7b54',badBrowser:"\u60a8\u7684\u6d4f\u89c8\u5668\u4f3c\u4e4e\u4e0d\u652f\u6301 WebGL\u3002",badBrowserMinVer:"\u60a8\u7684\u6d4f\u89c8\u5668\u4f3c\u4e4e\u4e0d\u652f\u6301 WebGL 1.0\u3002",
badHardware:"\u60a8\u7684\u786c\u4ef6\u4f3c\u4e4e\u4e0d\u652f\u6301 WebGL\u3002"},ui:{unnamedScene:"\u672a\u547d\u540d\u7684 Scene",sceneTitle:"${sceneName}  (CityEngine Web Scene)",about3d:"\u8be6\u7ec6\u4fe1\u606f",help:"\u5e2e\u52a9",webSceneViewer:"3D Web \u573a\u666f\u67e5\u770b\u5668",showLoadingDetails:"\u663e\u793a\u52a0\u8f7d\u8be6\u7ec6\u4fe1\u606f",detailsNoSummary:"\u65e0\u6458\u8981",detailsDesc:"\u63cf\u8ff0",detailsNoDesc:"\u65e0\u63cf\u8ff0",detailsMoreDetails:"\u8be6\u7ec6\u4fe1\u606f...",
author:"\u4f5c\u8005",lastModified:"\u4e0a\u6b21\u4fee\u6539\u65f6\u95f4",detailsSize:"${filesize} MB",size:"\u5927\u5c0f",layersPaneTitle:"\u56fe\u5c42",exitComparisonMode:"\u9000\u51fa\u6bd4\u8f83\u6a21\u5f0f",searchPaneTitle:"\u641c\u7d22",resultsFound:" \u4e2a\u67e5\u627e\u7ed3\u679c",searchHint:"\u67e5\u627e\u5bf9\u8c61\u3001\u5c5e\u6027\u548c\u66f4\u591a...",searchIncorrect:"\u9519\u8bef\u641c\u7d22\u8bcd",addtnlHiddenLyrs:"\u9690\u85cf\u56fe\u5c42\u4e2d\u7684\u5176\u4ed6\u7ed3\u679c:",resultInLayer:"\u5728\u56fe\u5c42\u4e2d ",
showLayer:"\u663e\u793a\u56fe\u5c42",nameIs:"\u540d\u79f0\u4e3a ",materialIs:"\u6750\u6599\u4e3a ",keyValueIs:"${key} \u662f ${value}",resultIn:" \u5728 ",settingsPaneTitle:"\u8bbe\u7f6e",sunLight:"\u9633\u5149",dragSunSliderHint:"\u62d6\u52a8\u6ed1\u5757",dateSpring:"\u6625\u5206(3 \u6708 20 \u65e5)",dateSummer:"\u590f\u81f3(6 \u6708 21 \u65e5)",dateFall:"\u79cb\u5206(9 \u6708 22 \u65e5)",dateWinter:"\u51ac\u81f3(12 \u6708 21 \u65e5)",sunrise:"\u65e5\u51fa",sunset:"\u65e5\u843d",shadowing:"\u9634\u5f71",
directShadow:"\u76f4\u63a5\u9634\u5f71(\u9633\u5149\u6295\u5c04)",diffuseShadow:"\u6563\u5c04\u9634\u5f71(\u73af\u5883\u906e\u6321)",sharePaneTitle:"\u5171\u4eab",sharePaneDisabledTitle:"\u7981\u7528\u5171\u4eab\u529f\u80fd",sharePaneDisabledInfo:"WebScene \u597d\u50cf\u6b63\u5728\x3ca href\x3d'http://en.wikipedia.org/wiki/Private_network' target\x3d'_blank'\x3e\u4e13\u7528\u7f51\u7edc\x3c/a\x3e(\u4e13\u7528 ip \u5730\u5740)\u4e2d\u8fd0\u884c\u3002\u7f51\u7edc\u4e4b\u5916\u7684\u7528\u6237\u5f88\u53ef\u80fd\u65e0\u6cd5\u8bbf\u95ee\u6b64 WebScene\u3002\u5c06 WebScene \u5e94\u7528\u7a0b\u5e8f\u53d1\u5e03\u5230\u516c\u5171\u670d\u52a1\u5668\uff0c\u4ee5\u4fbf\u4e0e\u5176\u4ed6\u7528\u6237\u5171\u4eab\u6b64\u94fe\u63a5\u3002",
sharePaneDisabledAction:"\u6211\u77e5\u9053\u6211\u5728\u505a\u4ec0\u4e48\u3002\u6fc0\u6d3b\u5171\u4eab\u7a97\u683c\u3002",shareNotPublicWarn:"\u6b64 Web \u573a\u666f\u672a\u5171\u4eab\u4e3a\u516c\u5171\u3002",shareNotPublicAnyway:"\u59cb\u7ec8\u5171\u4eab",shareNotPublicHint:"\u8981\u542f\u7528\u5171\u4eab\u6309\u94ae\uff0c\u8bf7\u5c06 Web \u573a\u666f\u9879\u76ee\u7684\u5171\u4eab\u8bbe\u7f6e\u9879\u8bbe\u7f6e\u4e3a\u516c\u5171\u5e76\u5237\u65b0\u3002",shareNotPublicEditItem:"\u7f16\u8f91 Web \u573a\u666f\u9879\u76ee...",
sharePaneDisabledByOrg:"\u6b64 Web \u573a\u666f\u65e0\u6cd5\u5171\u4eab\uff0c\u56e0\u4e3a\u8d35\u7ec4\u7ec7\u5df2\u7ecf\u7981\u7528\u6b64\u529f\u80fd\u3002",shortUrl:"\u77ed URL",longUrl:"\u957f URL",getUrl:"\u6b63\u5728\u83b7\u53d6 url...",shareSelectMethod:"\u9009\u62e9\u4ee5\u4e0b\u67d0\u79cd\u65b9\u6cd5\u6765\u5171\u4eab\u60a8\u7684 WebScene",shareLinkToWebScene:"\u6b64 WebScene \u89c6\u56fe\u7684\u94fe\u63a5",shareEmbed:"\u5d4c\u5165\u6b64 WebScene",shareFacebook:"\u5171\u4eab\u81f3 Facebook",
shareTwitter:"\u53d1\u5e03\u5230 Twitter",shareEmail:"\u53d1\u9001\u7535\u5b50\u90ae\u4ef6",shareLink:"\u5171\u4eab\u94fe\u63a5",shareFacebookTxt1:"\u6d4f\u89c8 ${sceneName} (CityEngine Web Scene)",shareFacebookTxt2:"\u4f7f\u7528 CityEngine \u6765\u521b\u5efa\u548c\u5171\u4eab\u60a8\u7684 3D Web Scene\u3002\u8bbf\u95ee esri.com/cityengine \u4e0b\u8f7d\u514d\u8d39\u7684 30 \u5929\u8bd5\u7528\u7248\u3002",shareTwitterTxt:"\u4f7f\u7528\u6d4f\u89c8\u5668\u5728 3D \u6a21\u5f0f\u4e0b\u6d4f\u89c8 '${sceneName}':\n",
shareEmailSubject:"3D \u6a21\u5f0f\u4e0b\u7684 ${sceneName} (CityEngine Web Scene)",shareEmailTxt1:"\u67e5\u770b\u6b64 CityEngine Web Scene:",shareEmailTxt2:"\u53ef\u4f7f\u7528 Esri CityEngine \u521b\u5efa\u548c\u5171\u4eab\u60a8\u81ea\u5df1\u7684 3D Web Scene\u3002\u8bbf\u95ee http://www.esri.com/cityengine \u6765\u4e0b\u8f7d\u514d\u8d39\u7684\u5177\u6709\u5b8c\u6574\u529f\u80fd\u7684 30 \u5929\u8bd5\u7528\u7248\u3002",this3dScene:"\u6b64 3D City Scene",infoPaneTitle:"\u4fe1\u606f",selectObj3D:"\u5728 3D Scene \u4e2d\u9009\u62e9\u5bf9\u8c61\u6765\u663e\u793a\u4fe1\u606f",
nameOfSelObject:"\u6240\u9009\u5bf9\u8c61\u7684\u540d\u79f0",infoProperties:"\u5c5e\u6027",infoAttributes:"\u5c5e\u6027",infoReports:"\u62a5\u544a",statsStatistics:"\u7edf\u8ba1\u4fe1\u606f",statsField:"\u5b57\u6bb5",statsValue:"\u503c",statsKey:"\u56fe\u4f8b",statsSum:"\u603b\u548c",statsAvg:"\u5747\u503c",statsCount:"\u8ba1\u6570",statsPercentage:"\u767e\u5206\u6bd4",thumbnailUploadSuccess:"\u4fdd\u5b58\u7684\u65b0\u7f29\u7565\u56fe",thumbnailUploadFail:"\u65e0\u6cd5\u4fdd\u5b58\u4e3a\u7f29\u7565\u56fe",
embedInWebsite:"\u5728\u7f51\u7ad9\u4e2d\u5d4c\u5165",embedLarge:"\u5927\u53f7(\u5b8c\u6574\u7528\u6237\u754c\u9762)",embedSmall:"\u5c0f\u53f7(\u7b80\u5316\u7684\u7528\u6237\u754c\u9762)",embedCustom:"\u81ea\u5b9a\u4e49\u5927\u5c0f",width:"\u5bbd\u5ea6",height:"\u9ad8\u5ea6",embedMsg:"\u5d4c\u5165\u5177\u6709 ${reducedOrFull} UI \u7684 Web \u67e5\u770b\u5668",embedReduced:"\u7cbe\u7b80",embedFull:"\u5b8c\u6574",enableAutoplay:"\u542f\u7528\u81ea\u52a8\u64ad\u653e",commentsTitle:"\u8bc4\u8bba",commentsByAuthor:"\u6765\u81ea\u4f5c\u8005",
commentsByOthers:"\u6765\u81ea\u5176\u4ed6\u4eba\u5458",comment:"\u8bc4\u8bba",commentHint:"\u4ee5\u53d1\u8868\u8bc4\u8bba",commentFail:"\u65e0\u6cd5\u53d1\u9001\u8bc4\u8bba",commentAdd:"\u6dfb\u52a0\u8bc4\u8bba...",commentPublish:"\u53d1\u5e03",commentsShowAll:"\u663e\u793a\u6240\u6709\u8bc4\u8bba",commentsShowAuthor:"\u4ec5\u663e\u793a\u4f5c\u8005\u7684\u8bc4\u8bba",commentsShowOthers:"\u663e\u793a\u5176\u4ed6\u4eba\u7684\u8bc4\u8bba",commentsDisabledByOrgMsg:"\u7ec4\u7ec7\u5df2\u7981\u6b62\u53d1\u8868\u8bc4\u8bba\u3002",
commentsPortalOnlyMsg:"\u8bc4\u8bba\u53ea\u9002\u7528\u4e8e ArcGIS Online/Portal for ArcGIS \u4e0a\u6258\u7ba1\u7684 WebScene\u3002",geoComment:"GeoComment",showMore:"\u663e\u793a\u66f4\u591a",ratingThanks:"\u611f\u8c22\u60a8\u8bc4\u4ef7\u6b64\u9879\u76ee!",ratingFail:"\u65e0\u6cd5\u66f4\u65b0\u8bc4\u7ea7",ratingOwnMsg:"\u4e0d\u80fd\u5bf9\u81ea\u5df1\u7684\u9879\u76ee\u8fdb\u884c\u8bc4\u7ea7",ratings:"\u8bc4\u7ea7",ratingHint:"\u8bc4\u4ef7\u6b64\u9879\u76ee",views:"\u6b21\u67e5\u770b",reducedUIexploreFull:"\u5728\u5b8c\u6574\u67e5\u770b\u5668\u4e2d\u6d4f\u89c8",
screenshot:"\u5c4f\u5e55\u622a\u56fe",viewportSize:"\u89c6\u53e3\u5927\u5c0f"},signInOut:{signIn:"\u767b\u5f55",signOut:"\u767b\u51fa",signOutDiffUser:"\u5e76\u4ee5\u5176\u4ed6\u7528\u6237\u8eab\u4efd\u52a0\u8f7d web \u573a\u666f",signOutNonPublicWarning:"\u60a8\u6b63\u5728\u6d4f\u89c8\u4e0d\u516c\u5f00\u7684 web \u573a\u666f\u3002\u767b\u51fa\u540e\u5c06\u79bb\u5f00\u6b64\u9875\u9762\u3002"},loader3ws:{wsFileInvalid:".3ws \u6587\u4ef6\u65e0\u6548: ",browse:"\u6d4f\u89c8",wsDragHere:"and select a local .3ws file or drag one here",
dataLoadedTime:"${seconds} \u79d2\u4e2d\u52a0\u8f7d\u7684\u6570\u636e",initializing:"\u6b63\u5728\u521d\u59cb\u5316...",detected3wsVersion:"Web Scene \u7248\u672c",unsupported3wsVersion:"\u4e0d\u652f\u6301\u7684 Web Scene (3ws) \u7248\u672c",wsDataInvalid:"\u65e0\u6548\u7684 Web Scene (3ws) \u6570\u636e",downloading:"\u6b63\u5728\u4e0b\u8f7d",reading:"\u6b63\u5728\u8bfb\u53d6",unableToLoadData:"\u65e0\u6cd5\u52a0\u8f7d\u6570\u636e",fallbackLoaderMsg:"\u56de\u9000\u5230 arraybuffer \u4e0a\u7684\u81ea\u5b9a\u4e49\u89e3\u538b\u548c\u81ea\u5b9a\u4e49 streamParser",
unableToLoadURL:"\u65e0\u6cd5\u52a0\u8f7d URL",errorStatus:" ${url} \u4e2d\u7684\u9519\u8bef\u72b6\u6001 ${status}",reqUnzip:"\u8bf7\u6c42\u89e3\u538b\u6570\u636e\uff0c ",reqGzip:"\u8bf7\u6c42 gzip \u65b9\u5f0f\u538b\u7f29\u7684\u6570\u636e\uff0c ",gotUnzip:"\u83b7\u53d6\u89e3\u538b\u6570\u636e",gotGzip:"\u83b7\u53d6 gzip \u65b9\u5f0f\u538b\u7f29\u7684\u6570\u636e",gzipInvalid:"\u65e0\u6548\u7684 gzip \u6587\u4ef6: ",customUnzipAndStream:"\u9488\u5bf9 arraybuffer \u4f7f\u7528\u81ea\u5b9a\u4e49\u89e3\u538b\u548c streamparser",
unpackingDone:"\u5df2\u5b8c\u6210\u89e3\u5305",unpackerEmpty:"\u89e3\u5305\u5668\u6ca1\u6709\u8fd4\u56de\u4efb\u4f55\u6570\u636e\u3002\u6d4f\u89c8\u5668\u53ef\u80fd\u5185\u5b58\u4e0d\u8db3\u3002",nativeCantProcess:"\u539f\u751f\u5206\u6790\u7a0b\u5e8f\u4e0d\u80fd\u5904\u7406\u54cd\u5e94\u7c7b\u578b\u4e3a arrayBuffer \u7684\u89e3\u538b\u6570\u636e ",streamParseOnUnzippedAB:"\u5bf9\u89e3\u538b\u7684 arraybuffer \u4f7f\u7528 streamparser",streamPOnlyOnAB:"\u53ea\u6709\u54cd\u5e94\u7c7b\u578b arraybuffer \u652f\u6301 StreamParser ",
zipOnlyAB:"\u4ec5\u54cd\u5e94\u7c7b\u578b arraybuffer \u652f\u6301\u538b\u7f29\u7684\u6570\u636e ",xhrEmpty:"\u8fd4\u56de\u6570\u636e\u4e3a\u7a7a\u3002\u6d4f\u89c8\u5668\u53ef\u80fd\u5185\u5b58\u4e0d\u8db3\u3002",noGzipEnc:"\u670d\u52a1\u5668\u6ca1\u6709\u8fd4\u56de gzip \u7f16\u7801\u6587\u4ef6\u5934"}});